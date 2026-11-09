# Fact dedd9f9a

Store id: b397c07e-3b71-4ab3-9aea-de6a391170cb

## Text

```text
def pk_fields(self)
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
- posted_at: `2026-11-09T23:44:55.5912730+00:00`

## Data

```json
{
  "end_line": 994,
  "entity_kind": "method",
  "parent": "Options",
  "start_line": 992,
  "symbol": "Options.pk_fields"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/options.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":992,"selector":"L992-L994","symbol":"Options.pk_fields"}`

## Referenced by

None.

## Subject

[django/db/models/options::Options.pk_fields](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 994,
    "entity_kind": "method",
    "parent": "Options",
    "start_line": 992,
    "symbol": "Options.pk_fields"
  },
  "id": "b397c07e-3b71-4ab3-9aea-de6a391170cb",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:55.5912730+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 992,
        "selector": "L992-L994",
        "symbol": "Options.pk_fields"
      },
      "rel": "derived_from",
      "target": "django/db/models/options.py"
    }
  ],
  "status": "live",
  "subject_id": "ab9ad08d-761f-4661-9ad9-3ee598291a8e",
  "subject_name": "django/db/models/options::Options.pk_fields",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def pk_fields(self)"
}
```
