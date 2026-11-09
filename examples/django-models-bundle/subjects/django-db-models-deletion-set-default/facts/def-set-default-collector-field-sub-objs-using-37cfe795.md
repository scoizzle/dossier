# Fact 37cfe795

Store id: ba848930-c938-4ec3-b7d0-2d63a4f12e86

## Text

```text
def SET_DEFAULT(collector, field, sub_objs, using)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:function`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:31:55.0741690+00:00`

## Data

```json
{
  "end_line": 77,
  "entity_kind": "function",
  "parent": "deletion",
  "start_line": 76,
  "symbol": "SET_DEFAULT"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/deletion.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":76,"selector":"L76-L77","symbol":"SET_DEFAULT"}`

## Referenced by

None.

## Subject

[django/db/models/deletion::SET_DEFAULT](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 77,
    "entity_kind": "function",
    "parent": "deletion",
    "start_line": 76,
    "symbol": "SET_DEFAULT"
  },
  "id": "ba848930-c938-4ec3-b7d0-2d63a4f12e86",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.0741690+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 76,
        "selector": "L76-L77",
        "symbol": "SET_DEFAULT"
      },
      "rel": "derived_from",
      "target": "django/db/models/deletion.py"
    }
  ],
  "status": "live",
  "subject_id": "ce13f4d2-ae51-4e3c-ab02-8ee813e6cc88",
  "subject_name": "django/db/models/deletion::SET_DEFAULT",
  "tags": [
    "entity:function"
  ],
  "text": "def SET_DEFAULT(collector, field, sub_objs, using)"
}
```
