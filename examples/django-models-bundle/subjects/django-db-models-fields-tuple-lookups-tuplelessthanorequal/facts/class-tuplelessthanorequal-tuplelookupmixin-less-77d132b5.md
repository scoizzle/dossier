# Fact 77d132b5

Store id: 1c53160d-b54e-43b7-88cf-b21afca8d8fb

## Text

```text
class TupleLessThanOrEqual(TupleLookupMixin, LessThanOrEqual)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:32:00.6135650+00:00`

## Data

```json
{
  "end_line": 300,
  "entity_kind": "class",
  "parent": "tuple_lookups",
  "start_line": 275,
  "symbol": "TupleLessThanOrEqual"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/tuple_lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":275,"selector":"L275-L300","symbol":"TupleLessThanOrEqual"}`

## Referenced by

None.

## Subject

[django/db/models/fields/tuple_lookups::TupleLessThanOrEqual](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 300,
    "entity_kind": "class",
    "parent": "tuple_lookups",
    "start_line": 275,
    "symbol": "TupleLessThanOrEqual"
  },
  "id": "1c53160d-b54e-43b7-88cf-b21afca8d8fb",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:00.6135650+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 275,
        "selector": "L275-L300",
        "symbol": "TupleLessThanOrEqual"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/tuple_lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "cab66d07-bb87-489c-a08b-442e730eb777",
  "subject_name": "django/db/models/fields/tuple_lookups::TupleLessThanOrEqual",
  "tags": [
    "entity:class"
  ],
  "text": "class TupleLessThanOrEqual(TupleLookupMixin, LessThanOrEqual)"
}
```
