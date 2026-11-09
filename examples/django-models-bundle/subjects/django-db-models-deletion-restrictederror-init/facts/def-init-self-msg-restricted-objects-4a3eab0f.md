# Fact 4a3eab0f

Store id: ac9a2146-815a-4453-8be8-23ce6ee0cbb8

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
- posted_at: `2026-11-09T22:39:40.9860580+00:00`

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
  "id": "ac9a2146-815a-4453-8be8-23ce6ee0cbb8",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:40.9860580+00:00"
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
  "subject_id": "48bbd256-da6a-4c9b-ad97-6ea2cd9f4fa0",
  "subject_name": "django/db/models/deletion::RestrictedError.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, msg, restricted_objects)"
}
```
