# Fact e452d984

Store id: e4f06a29-29ba-4d57-87dc-5f613e83ea83

## Text

```text
def cached_col(self)
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
- posted_at: `2026-11-09T22:39:43.4275220+00:00`

## Data

```json
{
  "end_line": 39,
  "entity_kind": "method",
  "parent": "GeneratedField",
  "start_line": 35,
  "symbol": "GeneratedField.cached_col"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/generated.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":35,"selector":"L35-L39","symbol":"GeneratedField.cached_col"}`

## Referenced by

None.

## Subject

[django/db/models/fields/generated::GeneratedField.cached_col](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 39,
    "entity_kind": "method",
    "parent": "GeneratedField",
    "start_line": 35,
    "symbol": "GeneratedField.cached_col"
  },
  "id": "e4f06a29-29ba-4d57-87dc-5f613e83ea83",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:43.4275220+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 35,
        "selector": "L35-L39",
        "symbol": "GeneratedField.cached_col"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/generated.py"
    }
  ],
  "status": "live",
  "subject_id": "84342c2f-db84-45c5-8c59-fec02fd9d220",
  "subject_name": "django/db/models/fields/generated::GeneratedField.cached_col",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def cached_col(self)"
}
```
