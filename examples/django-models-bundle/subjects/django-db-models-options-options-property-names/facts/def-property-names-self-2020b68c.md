# Fact 2020b68c

Store id: cebbf410-f960-404f-b6dd-b36084ec2d81

## Text

```text
def _property_names(self)
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
- posted_at: `2026-11-09T23:44:55.5965780+00:00`

## Data

```json
{
  "end_line": 1012,
  "entity_kind": "method",
  "parent": "Options",
  "start_line": 1000,
  "symbol": "Options._property_names"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/options.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1000,"selector":"L1000-L1012","symbol":"Options._property_names"}`

## Items

```json
[
  {
    "text": "Return a set of the names of the properties defined on the model.",
    "locator": {
      "line": 1002
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/options::Options._property_names](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1012,
    "entity_kind": "method",
    "parent": "Options",
    "start_line": 1000,
    "symbol": "Options._property_names"
  },
  "id": "cebbf410-f960-404f-b6dd-b36084ec2d81",
  "items": [
    {
      "locator": {
        "line": 1002
      },
      "text": "Return a set of the names of the properties defined on the model."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:55.5965780+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1000,
        "selector": "L1000-L1012",
        "symbol": "Options._property_names"
      },
      "rel": "derived_from",
      "target": "django/db/models/options.py"
    }
  ],
  "status": "live",
  "subject_id": "46fc2948-77fa-4473-9dca-1ed2058bb7fb",
  "subject_name": "django/db/models/options::Options._property_names",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def _property_names(self)"
}
```
