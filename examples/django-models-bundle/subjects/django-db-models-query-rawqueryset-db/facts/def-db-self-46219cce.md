# Fact 46219cce

Store id: 8bb6093e-2649-49d0-bca2-add373b17e32

## Text

```text
def db(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`, `decorator:property`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:32:04.7664680+00:00`

## Data

```json
{
  "end_line": 2525,
  "entity_kind": "method",
  "parent": "RawQuerySet",
  "start_line": 2522,
  "symbol": "RawQuerySet.db"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2522,"selector":"L2522-L2525","symbol":"RawQuerySet.db"}`

## Items

```json
[
  {
    "text": "Return the database used if this query is executed now.",
    "locator": {
      "line": 2524
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/query::RawQuerySet.db](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2525,
    "entity_kind": "method",
    "parent": "RawQuerySet",
    "start_line": 2522,
    "symbol": "RawQuerySet.db"
  },
  "id": "8bb6093e-2649-49d0-bca2-add373b17e32",
  "items": [
    {
      "locator": {
        "line": 2524
      },
      "text": "Return the database used if this query is executed now."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:04.7664680+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2522,
        "selector": "L2522-L2525",
        "symbol": "RawQuerySet.db"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "a806c470-628f-4624-9c5c-b3dfe7b46eab",
  "subject_name": "django/db/models/query::RawQuerySet.db",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def db(self)"
}
```
