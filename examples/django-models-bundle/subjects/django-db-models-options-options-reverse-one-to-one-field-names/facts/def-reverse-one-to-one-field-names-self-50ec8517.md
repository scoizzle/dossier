# Fact 50ec8517

Store id: 51b328a8-e7fb-4ac6-83c8-66abb3cbdba0

## Text

```text
def _reverse_one_to_one_field_names(self)
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
- posted_at: `2026-11-09T23:32:04.0518310+00:00`

## Data

```json
{
  "end_line": 1038,
  "entity_kind": "method",
  "parent": "Options",
  "start_line": 1030,
  "symbol": "Options._reverse_one_to_one_field_names"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/options.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1030,"selector":"L1030-L1038","symbol":"Options._reverse_one_to_one_field_names"}`

## Items

```json
[
  {
    "text": "Return a set of reverse one to one field names pointing to the current model.",
    "locator": {
      "line": 1032
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/options::Options._reverse_one_to_one_field_names](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1038,
    "entity_kind": "method",
    "parent": "Options",
    "start_line": 1030,
    "symbol": "Options._reverse_one_to_one_field_names"
  },
  "id": "51b328a8-e7fb-4ac6-83c8-66abb3cbdba0",
  "items": [
    {
      "locator": {
        "line": 1032
      },
      "text": "Return a set of reverse one to one field names pointing to the current model."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:04.0518310+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1030,
        "selector": "L1030-L1038",
        "symbol": "Options._reverse_one_to_one_field_names"
      },
      "rel": "derived_from",
      "target": "django/db/models/options.py"
    }
  ],
  "status": "live",
  "subject_id": "5e4dc713-7bb3-469a-9daa-78755b8394a8",
  "subject_name": "django/db/models/options::Options._reverse_one_to_one_field_names",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def _reverse_one_to_one_field_names(self)"
}
```
