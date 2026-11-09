# Fact 9a70bfc2

Store id: 3259d091-fe42-42a7-81f1-27be08db906d

## Text

```text
def as_sql(self, compiler, connection)
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
- posted_at: `2026-11-09T23:32:00.5787290+00:00`

## Data

```json
{
  "end_line": 152,
  "entity_kind": "method",
  "parent": "TupleLookupMixin",
  "start_line": 135,
  "symbol": "TupleLookupMixin.as_sql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/tuple_lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":135,"selector":"L135-L152","symbol":"TupleLookupMixin.as_sql"}`

## Referenced by

None.

## Subject

[django/db/models/fields/tuple_lookups::TupleLookupMixin.as_sql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 152,
    "entity_kind": "method",
    "parent": "TupleLookupMixin",
    "start_line": 135,
    "symbol": "TupleLookupMixin.as_sql"
  },
  "id": "3259d091-fe42-42a7-81f1-27be08db906d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:00.5787290+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 135,
        "selector": "L135-L152",
        "symbol": "TupleLookupMixin.as_sql"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/tuple_lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "54a69f19-1c72-4627-9365-bd0ebd5efd81",
  "subject_name": "django/db/models/fields/tuple_lookups::TupleLookupMixin.as_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sql(self, compiler, connection)"
}
```
