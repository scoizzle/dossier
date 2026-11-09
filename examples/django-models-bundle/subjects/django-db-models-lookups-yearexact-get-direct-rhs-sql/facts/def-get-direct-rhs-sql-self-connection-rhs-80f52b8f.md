# Fact 80f52b8f

Store id: 6a5eda60-c1ed-45b3-ad5c-10bb1a02560a

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
- posted_at: `2026-11-09T23:44:55.0686750+00:00`

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
  "id": "6a5eda60-c1ed-45b3-ad5c-10bb1a02560a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:55.0686750+00:00"
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
  "subject_id": "9e881c79-50de-4bcf-9d80-7e0f8f360899",
  "subject_name": "django/db/models/lookups::YearExact.get_direct_rhs_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def get_direct_rhs_sql(self, connection, rhs)"
}
```
