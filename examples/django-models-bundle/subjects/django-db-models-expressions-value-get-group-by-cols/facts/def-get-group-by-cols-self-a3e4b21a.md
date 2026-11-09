# Fact a3e4b21a

Store id: 183a03c8-b030-4710-b81e-9cda3d8afef1

## Text

```text
def get_group_by_cols(self)
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
- posted_at: `2026-11-09T23:31:55.8628790+00:00`

## Data

```json
{
  "end_line": 1213,
  "entity_kind": "method",
  "parent": "Value",
  "start_line": 1212,
  "symbol": "Value.get_group_by_cols"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1212,"selector":"L1212-L1213","symbol":"Value.get_group_by_cols"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Value.get_group_by_cols](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1213,
    "entity_kind": "method",
    "parent": "Value",
    "start_line": 1212,
    "symbol": "Value.get_group_by_cols"
  },
  "id": "183a03c8-b030-4710-b81e-9cda3d8afef1",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.8628790+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1212,
        "selector": "L1212-L1213",
        "symbol": "Value.get_group_by_cols"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "a8d7d8c5-ce36-4d35-bc54-c20a52f4a6af",
  "subject_name": "django/db/models/expressions::Value.get_group_by_cols",
  "tags": [
    "entity:method"
  ],
  "text": "def get_group_by_cols(self)"
}
```
