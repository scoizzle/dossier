# Fact 38d87c4d

Store id: 4bdda9f1-f117-4b66-84cf-bd0a454e1559

## Text

```text
class TupleLookupMixin
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
- posted_at: `2026-11-09T22:39:45.5545380+00:00`

## Data

```json
{
  "end_line": 152,
  "entity_kind": "class",
  "parent": "tuple_lookups",
  "start_line": 50,
  "symbol": "TupleLookupMixin"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/tuple_lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":50,"selector":"L50-L152","symbol":"TupleLookupMixin"}`

## Referenced by

None.

## Subject

[django/db/models/fields/tuple_lookups::TupleLookupMixin](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 152,
    "entity_kind": "class",
    "parent": "tuple_lookups",
    "start_line": 50,
    "symbol": "TupleLookupMixin"
  },
  "id": "4bdda9f1-f117-4b66-84cf-bd0a454e1559",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:45.5545380+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 50,
        "selector": "L50-L152",
        "symbol": "TupleLookupMixin"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/tuple_lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "e99803a5-a203-4112-91b1-03eaaf821ed1",
  "subject_name": "django/db/models/fields/tuple_lookups::TupleLookupMixin",
  "tags": [
    "entity:class"
  ],
  "text": "class TupleLookupMixin"
}
```
