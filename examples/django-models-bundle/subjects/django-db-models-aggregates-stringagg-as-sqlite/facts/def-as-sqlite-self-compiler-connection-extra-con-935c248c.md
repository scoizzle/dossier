# Fact 935c248c

Store id: 77abba03-099e-4196-a422-658fd2e10331

## Text

```text
def as_sqlite(self, compiler, connection, **extra_context)
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
- posted_at: `2026-11-09T23:44:48.4058850+00:00`

## Data

```json
{
  "end_line": 449,
  "entity_kind": "method",
  "parent": "StringAgg",
  "start_line": 422,
  "symbol": "StringAgg.as_sqlite"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/aggregates.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":422,"selector":"L422-L449","symbol":"StringAgg.as_sqlite"}`

## Referenced by

None.

## Subject

[django/db/models/aggregates::StringAgg.as_sqlite](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 449,
    "entity_kind": "method",
    "parent": "StringAgg",
    "start_line": 422,
    "symbol": "StringAgg.as_sqlite"
  },
  "id": "77abba03-099e-4196-a422-658fd2e10331",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:48.4058850+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 422,
        "selector": "L422-L449",
        "symbol": "StringAgg.as_sqlite"
      },
      "rel": "derived_from",
      "target": "django/db/models/aggregates.py"
    }
  ],
  "status": "live",
  "subject_id": "728dda97-7f2e-48f3-bcca-a0ce3f843a62",
  "subject_name": "django/db/models/aggregates::StringAgg.as_sqlite",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sqlite(self, compiler, connection, **extra_context)"
}
```
