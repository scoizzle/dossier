# Fact 3233aaa6

Store id: 5b32f600-698a-4811-b432-150a411bc7c3

## Text

```text
def get_fallback_sql(self, compiler, connection)
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
- posted_at: `2026-11-09T22:39:45.6270320+00:00`

## Data

```json
{
  "end_line": 300,
  "entity_kind": "method",
  "parent": "TupleLessThanOrEqual",
  "start_line": 276,
  "symbol": "TupleLessThanOrEqual.get_fallback_sql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/tuple_lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":276,"selector":"L276-L300","symbol":"TupleLessThanOrEqual.get_fallback_sql"}`

## Referenced by

None.

## Subject

[django/db/models/fields/tuple_lookups::TupleLessThanOrEqual.get_fallback_sql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 300,
    "entity_kind": "method",
    "parent": "TupleLessThanOrEqual",
    "start_line": 276,
    "symbol": "TupleLessThanOrEqual.get_fallback_sql"
  },
  "id": "5b32f600-698a-4811-b432-150a411bc7c3",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:45.6270320+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 276,
        "selector": "L276-L300",
        "symbol": "TupleLessThanOrEqual.get_fallback_sql"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/tuple_lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "d326adde-808c-40b9-9a08-f7841a8b2df1",
  "subject_name": "django/db/models/fields/tuple_lookups::TupleLessThanOrEqual.get_fallback_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def get_fallback_sql(self, compiler, connection)"
}
```
