# Fact 889ecdab

Store id: 46f6e003-e672-411a-9881-5f4bb76d01c1

## Text

```text
def __repr__(self)
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
- posted_at: `2026-11-09T23:44:49.5748600+00:00`

## Data

```json
{
  "end_line": 1458,
  "entity_kind": "method",
  "parent": "Ref",
  "start_line": 1457,
  "symbol": "Ref.__repr__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1457,"selector":"L1457-L1458","symbol":"Ref.__repr__"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Ref.__repr__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1458,
    "entity_kind": "method",
    "parent": "Ref",
    "start_line": 1457,
    "symbol": "Ref.__repr__"
  },
  "id": "46f6e003-e672-411a-9881-5f4bb76d01c1",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.5748600+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1457,
        "selector": "L1457-L1458",
        "symbol": "Ref.__repr__"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "9b1a4a39-d6e3-4de9-9b34-d211177a3e23",
  "subject_name": "django/db/models/expressions::Ref.__repr__",
  "tags": [
    "entity:method"
  ],
  "text": "def __repr__(self)"
}
```
