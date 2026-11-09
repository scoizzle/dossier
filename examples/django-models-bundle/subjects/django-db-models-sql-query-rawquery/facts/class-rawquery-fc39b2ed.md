# Fact fc39b2ed

Store id: c2ce2ae3-9a3e-4d12-8fd8-01233ea26175

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
- posted_at: `2026-11-09T23:44:58.5309640+00:00`

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
  "id": "c2ce2ae3-9a3e-4d12-8fd8-01233ea26175",
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
    "posted_at": "2026-11-09T23:44:58.5309640+00:00"
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
  "subject_id": "cb5fd61d-de34-4319-84c4-5a1a92caf36d",
  "subject_name": "django/db/models/sql/query::RawQuery",
  "tags": [
    "entity:class"
  ],
  "text": "class RawQuery"
}
```
