# Fact 25c11b91

Store id: 974c67ee-8b2f-4107-809a-5d0073d2289f

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
- posted_at: `2026-11-09T23:44:52.7413140+00:00`

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
  "id": "974c67ee-8b2f-4107-809a-5d0073d2289f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:52.7413140+00:00"
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
  "subject_id": "d7f2fe56-03ee-488d-a655-6b47708f881c",
  "subject_name": "django/db/models/fields/tuple_lookups::TupleLookupMixin.get_prep_lhs",
  "tags": [
    "entity:method"
  ],
  "text": "def get_prep_lhs(self)"
}
```
