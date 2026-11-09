# Fact 9649596b

Store id: b5ec7a0f-7914-4c58-ab2f-96849d591e9d

## Text

```text
def get_rhs_op(self, connection, rhs)
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
- posted_at: `2026-11-09T22:39:48.1990400+00:00`

## Data

```json
{
  "end_line": 662,
  "entity_kind": "method",
  "parent": "Range",
  "start_line": 661,
  "symbol": "Range.get_rhs_op"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":661,"selector":"L661-L662","symbol":"Range.get_rhs_op"}`

## Referenced by

None.

## Subject

[django/db/models/lookups::Range.get_rhs_op](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 662,
    "entity_kind": "method",
    "parent": "Range",
    "start_line": 661,
    "symbol": "Range.get_rhs_op"
  },
  "id": "b5ec7a0f-7914-4c58-ab2f-96849d591e9d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:48.1990400+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 661,
        "selector": "L661-L662",
        "symbol": "Range.get_rhs_op"
      },
      "rel": "derived_from",
      "target": "django/db/models/lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "caa3990e-e249-4047-a221-73b8dab0a4f3",
  "subject_name": "django/db/models/lookups::Range.get_rhs_op",
  "tags": [
    "entity:method"
  ],
  "text": "def get_rhs_op(self, connection, rhs)"
}
```
