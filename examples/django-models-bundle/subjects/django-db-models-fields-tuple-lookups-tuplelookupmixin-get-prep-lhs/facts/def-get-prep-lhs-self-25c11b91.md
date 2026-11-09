# Fact 25c11b91

Store id: 3fb5faca-22a4-446f-bcc2-79438856b215

## Text

```text
def get_prep_lhs(self)
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
- posted_at: `2026-11-09T23:32:00.5681400+00:00`

## Data

```json
{
  "end_line": 99,
  "entity_kind": "method",
  "parent": "TupleLookupMixin",
  "start_line": 96,
  "symbol": "TupleLookupMixin.get_prep_lhs"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/tuple_lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":96,"selector":"L96-L99","symbol":"TupleLookupMixin.get_prep_lhs"}`

## Referenced by

None.

## Subject

[django/db/models/fields/tuple_lookups::TupleLookupMixin.get_prep_lhs](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 99,
    "entity_kind": "method",
    "parent": "TupleLookupMixin",
    "start_line": 96,
    "symbol": "TupleLookupMixin.get_prep_lhs"
  },
  "id": "3fb5faca-22a4-446f-bcc2-79438856b215",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:00.5681400+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 96,
        "selector": "L96-L99",
        "symbol": "TupleLookupMixin.get_prep_lhs"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/tuple_lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "000dfb44-7c13-4b5b-b62e-5af84426c179",
  "subject_name": "django/db/models/fields/tuple_lookups::TupleLookupMixin.get_prep_lhs",
  "tags": [
    "entity:method"
  ],
  "text": "def get_prep_lhs(self)"
}
```
