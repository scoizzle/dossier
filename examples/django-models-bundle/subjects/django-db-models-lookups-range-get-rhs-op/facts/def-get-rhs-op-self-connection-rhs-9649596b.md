# Fact 9649596b

Store id: 302f7b44-2d67-4b80-a5bc-b4a9e1f75db2

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
- posted_at: `2026-11-09T23:44:55.0386160+00:00`

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
  "id": "302f7b44-2d67-4b80-a5bc-b4a9e1f75db2",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:55.0386160+00:00"
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
  "subject_id": "192f1987-cd5d-47fa-96e6-e5d15d362c32",
  "subject_name": "django/db/models/lookups::Range.get_rhs_op",
  "tags": [
    "entity:method"
  ],
  "text": "def get_rhs_op(self, connection, rhs)"
}
```
