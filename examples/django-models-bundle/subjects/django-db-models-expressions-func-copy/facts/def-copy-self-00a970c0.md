# Fact 00a970c0

Store id: 05e8d50d-f0d0-487c-a833-b5cef22153e1

## Text

```text
def copy(self)
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
- posted_at: `2026-11-09T23:31:55.8567010+00:00`

## Data

```json
{
  "end_line": 1140,
  "entity_kind": "method",
  "parent": "Func",
  "start_line": 1136,
  "symbol": "Func.copy"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1136,"selector":"L1136-L1140","symbol":"Func.copy"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Func.copy](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1140,
    "entity_kind": "method",
    "parent": "Func",
    "start_line": 1136,
    "symbol": "Func.copy"
  },
  "id": "05e8d50d-f0d0-487c-a833-b5cef22153e1",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.8567010+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1136,
        "selector": "L1136-L1140",
        "symbol": "Func.copy"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "cdb453ac-8ad5-4f55-bcd8-1df979cf0b5c",
  "subject_name": "django/db/models/expressions::Func.copy",
  "tags": [
    "entity:method"
  ],
  "text": "def copy(self)"
}
```
