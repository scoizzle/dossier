# Fact 5d76284a

Store id: 42ce7eea-8dc4-4cb6-bb3f-3ec607b5a6e9

## Text

```text
def identity(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`, `decorator:cached_property`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:31:55.8014660+00:00`

## Data

```json
{
  "end_line": 554,
  "entity_kind": "method",
  "parent": "Expression",
  "start_line": 540,
  "symbol": "Expression.identity"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":540,"selector":"L540-L554","symbol":"Expression.identity"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Expression.identity](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 554,
    "entity_kind": "method",
    "parent": "Expression",
    "start_line": 540,
    "symbol": "Expression.identity"
  },
  "id": "42ce7eea-8dc4-4cb6-bb3f-3ec607b5a6e9",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.8014660+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 540,
        "selector": "L540-L554",
        "symbol": "Expression.identity"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "07fb156e-bf29-4127-a8ba-2a562d37b571",
  "subject_name": "django/db/models/expressions::Expression.identity",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def identity(self)"
}
```
