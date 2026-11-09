# Fact b4a9e2d8

Store id: 4ca35275-d7db-4b51-90d8-bde70030429f

## Text

```text
def contains_expressions(self)
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
- posted_at: `2026-11-09T23:44:54.6686040+00:00`

## Data

```json
{
  "end_line": 84,
  "entity_kind": "method",
  "parent": "Index",
  "start_line": 82,
  "symbol": "Index.contains_expressions"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/indexes.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":82,"selector":"L82-L84","symbol":"Index.contains_expressions"}`

## Referenced by

None.

## Subject

[django/db/models/indexes::Index.contains_expressions](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 84,
    "entity_kind": "method",
    "parent": "Index",
    "start_line": 82,
    "symbol": "Index.contains_expressions"
  },
  "id": "4ca35275-d7db-4b51-90d8-bde70030429f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:54.6686040+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 82,
        "selector": "L82-L84",
        "symbol": "Index.contains_expressions"
      },
      "rel": "derived_from",
      "target": "django/db/models/indexes.py"
    }
  ],
  "status": "live",
  "subject_id": "c52c3d87-148a-40cb-a398-4ebd315e88fc",
  "subject_name": "django/db/models/indexes::Index.contains_expressions",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def contains_expressions(self)"
}
```
