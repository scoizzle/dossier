# Fact 4a3eab0f

Store id: e47abecc-60b6-42c0-90e0-e57cee387781

## Text

```text
def __init__(self, msg, restricted_objects)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:48.8978860+00:00`

## Data

```json
{
  "end_line": 19,
  "entity_kind": "method",
  "parent": "RestrictedError",
  "start_line": 17,
  "symbol": "RestrictedError.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/deletion.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":17,"selector":"L17-L19","symbol":"RestrictedError.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/deletion::RestrictedError.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 19,
    "entity_kind": "method",
    "parent": "RestrictedError",
    "start_line": 17,
    "symbol": "RestrictedError.__init__"
  },
  "id": "e47abecc-60b6-42c0-90e0-e57cee387781",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:48.8978860+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 17,
        "selector": "L17-L19",
        "symbol": "RestrictedError.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/deletion.py"
    }
  ],
  "status": "live",
  "subject_id": "760d3ca7-d52e-483f-b216-a2be08a6acbe",
  "subject_name": "django/db/models/deletion::RestrictedError.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, msg, restricted_objects)"
}
```
