# Fact fc39b2ed

Store id: c6c73e2e-ca11-4053-a49e-7d44677ffb56

## Text

```text
class RawQuery
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
- posted_at: `2026-11-09T22:39:51.1805310+00:00`

## Data

```json
{
  "end_line": 225,
  "entity_kind": "class",
  "parent": "query",
  "start_line": 155,
  "symbol": "RawQuery"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":155,"selector":"L155-L225","symbol":"RawQuery"}`

## Items

```json
[
  {
    "text": "A single raw SQL query.",
    "locator": {
      "line": 156
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/sql/query::RawQuery](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 225,
    "entity_kind": "class",
    "parent": "query",
    "start_line": 155,
    "symbol": "RawQuery"
  },
  "id": "c6c73e2e-ca11-4053-a49e-7d44677ffb56",
  "items": [
    {
      "locator": {
        "line": 156
      },
      "text": "A single raw SQL query."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:51.1805310+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 155,
        "selector": "L155-L225",
        "symbol": "RawQuery"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "1a44227e-df7a-4343-b1eb-9d1f3b8fd915",
  "subject_name": "django/db/models/sql/query::RawQuery",
  "tags": [
    "entity:class"
  ],
  "text": "class RawQuery"
}
```
