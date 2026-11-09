# Fact 9c35ea6e

Store id: 265b7288-8148-4857-9c29-e97e44b74048

## Text

```text
def get_lhs_str(self)
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
- posted_at: `2026-11-09T22:39:45.5772090+00:00`

## Data

```json
{
  "end_line": 94,
  "entity_kind": "method",
  "parent": "TupleLookupMixin",
  "start_line": 86,
  "symbol": "TupleLookupMixin.get_lhs_str"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/tuple_lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":86,"selector":"L86-L94","symbol":"TupleLookupMixin.get_lhs_str"}`

## Referenced by

None.

## Subject

[django/db/models/fields/tuple_lookups::TupleLookupMixin.get_lhs_str](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 94,
    "entity_kind": "method",
    "parent": "TupleLookupMixin",
    "start_line": 86,
    "symbol": "TupleLookupMixin.get_lhs_str"
  },
  "id": "265b7288-8148-4857-9c29-e97e44b74048",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:45.5772090+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 86,
        "selector": "L86-L94",
        "symbol": "TupleLookupMixin.get_lhs_str"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/tuple_lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "4a8e58cd-c2ca-4211-baa6-8892b5fea0c8",
  "subject_name": "django/db/models/fields/tuple_lookups::TupleLookupMixin.get_lhs_str",
  "tags": [
    "entity:method"
  ],
  "text": "def get_lhs_str(self)"
}
```
