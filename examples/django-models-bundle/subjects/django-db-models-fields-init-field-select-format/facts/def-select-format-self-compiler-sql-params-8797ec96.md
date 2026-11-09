# Fact 8797ec96

Store id: 1f63f2bf-7bf6-4a08-ad60-50c9b7ddf373

## Text

```text
def select_format(self, compiler, sql, params)
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
- posted_at: `2026-11-09T22:39:42.2956330+00:00`

## Data

```json
{
  "end_line": 603,
  "entity_kind": "method",
  "parent": "Field",
  "start_line": 597,
  "symbol": "Field.select_format"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":597,"selector":"L597-L603","symbol":"Field.select_format"}`

## Items

```json
[
  {
    "text": "Custom format for select clauses. For example, GIS columns need to be selected as AsText(table.col) on MySQL as the table.col data can't be used by Django.",
    "locator": {
      "line": 598
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::Field.select_format](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 603,
    "entity_kind": "method",
    "parent": "Field",
    "start_line": 597,
    "symbol": "Field.select_format"
  },
  "id": "1f63f2bf-7bf6-4a08-ad60-50c9b7ddf373",
  "items": [
    {
      "locator": {
        "line": 598
      },
      "text": "Custom format for select clauses. For example, GIS columns need to be selected as AsText(table.col) on MySQL as the table.col data can't be used by Django."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.2956330+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 597,
        "selector": "L597-L603",
        "symbol": "Field.select_format"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "e433ff19-84f7-4e02-aeb9-fe24d3a038f8",
  "subject_name": "django/db/models/fields/__init__::Field.select_format",
  "tags": [
    "entity:method"
  ],
  "text": "def select_format(self, compiler, sql, params)"
}
```
