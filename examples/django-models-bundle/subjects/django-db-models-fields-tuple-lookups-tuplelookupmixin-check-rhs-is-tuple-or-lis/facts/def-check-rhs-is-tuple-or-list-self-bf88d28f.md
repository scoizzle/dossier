# Fact bf88d28f

Store id: 222f5430-cd41-4592-9d31-d2c8e23df582

## Text

```text
def check_rhs_is_tuple_or_list(self)
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
- posted_at: `2026-11-09T23:44:52.7039570+00:00`

## Data

```json
{
  "end_line": 67,
  "entity_kind": "method",
  "parent": "TupleLookupMixin",
  "start_line": 62,
  "symbol": "TupleLookupMixin.check_rhs_is_tuple_or_list"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/tuple_lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":62,"selector":"L62-L67","symbol":"TupleLookupMixin.check_rhs_is_tuple_or_list"}`

## Referenced by

None.

## Subject

[django/db/models/fields/tuple_lookups::TupleLookupMixin.check_rhs_is_tuple_or_list](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 67,
    "entity_kind": "method",
    "parent": "TupleLookupMixin",
    "start_line": 62,
    "symbol": "TupleLookupMixin.check_rhs_is_tuple_or_list"
  },
  "id": "222f5430-cd41-4592-9d31-d2c8e23df582",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:52.7039570+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 62,
        "selector": "L62-L67",
        "symbol": "TupleLookupMixin.check_rhs_is_tuple_or_list"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/tuple_lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "12a5f301-f99f-4e87-9af2-2f64259098ac",
  "subject_name": "django/db/models/fields/tuple_lookups::TupleLookupMixin.check_rhs_is_tuple_or_list",
  "tags": [
    "entity:method"
  ],
  "text": "def check_rhs_is_tuple_or_list(self)"
}
```
