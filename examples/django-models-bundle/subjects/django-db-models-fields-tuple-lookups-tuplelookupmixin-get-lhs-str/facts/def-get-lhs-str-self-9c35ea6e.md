# Fact 9c35ea6e

Store id: 4fd03ac6-b8e5-408c-9abc-870764656184

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
- posted_at: `2026-11-09T23:44:52.7358010+00:00`

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
  "id": "4fd03ac6-b8e5-408c-9abc-870764656184",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:52.7358010+00:00"
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
  "subject_id": "9644f502-3e92-4eaa-a205-300040b4df75",
  "subject_name": "django/db/models/fields/tuple_lookups::TupleLookupMixin.get_lhs_str",
  "tags": [
    "entity:method"
  ],
  "text": "def get_lhs_str(self)"
}
```
