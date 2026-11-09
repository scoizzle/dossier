# Fact 80f52b8f

Store id: 9f38989e-4939-4fdf-8929-317128c101e5

## Text

```text
def get_direct_rhs_sql(self, connection, rhs)
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
- posted_at: `2026-11-09T22:39:48.2389580+00:00`

## Data

```json
{
  "end_line": 755,
  "entity_kind": "method",
  "parent": "YearExact",
  "start_line": 754,
  "symbol": "YearExact.get_direct_rhs_sql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":754,"selector":"L754-L755","symbol":"YearExact.get_direct_rhs_sql"}`

## Referenced by

None.

## Subject

[django/db/models/lookups::YearExact.get_direct_rhs_sql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 755,
    "entity_kind": "method",
    "parent": "YearExact",
    "start_line": 754,
    "symbol": "YearExact.get_direct_rhs_sql"
  },
  "id": "9f38989e-4939-4fdf-8929-317128c101e5",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:48.2389580+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 754,
        "selector": "L754-L755",
        "symbol": "YearExact.get_direct_rhs_sql"
      },
      "rel": "derived_from",
      "target": "django/db/models/lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "d2ca538e-487a-4f10-840c-2bc5422cec7f",
  "subject_name": "django/db/models/lookups::YearExact.get_direct_rhs_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def get_direct_rhs_sql(self, connection, rhs)"
}
```
