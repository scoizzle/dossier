# Fact bf88d28f

Store id: 0d3b5dcc-9f86-4652-a735-bd5de6ab30d0

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
- posted_at: `2026-11-09T22:39:45.5599990+00:00`

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
  "id": "0d3b5dcc-9f86-4652-a735-bd5de6ab30d0",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:45.5599990+00:00"
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
  "subject_id": "fad8168e-b633-436d-8864-cf47807b8893",
  "subject_name": "django/db/models/fields/tuple_lookups::TupleLookupMixin.check_rhs_is_tuple_or_list",
  "tags": [
    "entity:method"
  ],
  "text": "def check_rhs_is_tuple_or_list(self)"
}
```
