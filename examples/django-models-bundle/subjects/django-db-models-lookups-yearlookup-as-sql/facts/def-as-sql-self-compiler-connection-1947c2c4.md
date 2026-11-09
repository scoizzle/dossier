# Fact 1947c2c4

Store id: ff96141c-459d-435a-b1ab-40d4e5604313

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
- posted_at: `2026-11-09T22:39:48.2236940+00:00`

## Data

```json
{
  "end_line": 742,
  "entity_kind": "method",
  "parent": "YearLookup",
  "start_line": 730,
  "symbol": "YearLookup.as_sql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":730,"selector":"L730-L742","symbol":"YearLookup.as_sql"}`

## Referenced by

None.

## Subject

[django/db/models/lookups::YearLookup.as_sql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 742,
    "entity_kind": "method",
    "parent": "YearLookup",
    "start_line": 730,
    "symbol": "YearLookup.as_sql"
  },
  "id": "ff96141c-459d-435a-b1ab-40d4e5604313",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:48.2236940+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 730,
        "selector": "L730-L742",
        "symbol": "YearLookup.as_sql"
      },
      "rel": "derived_from",
      "target": "django/db/models/lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "3cabd8b4-9b11-4952-9fda-a4a797474c77",
  "subject_name": "django/db/models/lookups::YearLookup.as_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sql(self, compiler, connection)"
}
```
