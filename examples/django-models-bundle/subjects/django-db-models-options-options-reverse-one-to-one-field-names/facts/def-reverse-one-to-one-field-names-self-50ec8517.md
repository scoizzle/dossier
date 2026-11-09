# Fact 50ec8517

Store id: 193170e1-85e6-4a70-af8e-d3f14994b47a

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
- posted_at: `2026-11-09T23:44:55.6038710+00:00`

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
  "id": "193170e1-85e6-4a70-af8e-d3f14994b47a",
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
    "posted_at": "2026-11-09T23:44:55.6038710+00:00"
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
  "subject_id": "b2ada322-0f48-4346-a813-a6701ef115de",
  "subject_name": "django/db/models/options::Options._reverse_one_to_one_field_names",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def _reverse_one_to_one_field_names(self)"
}
```
