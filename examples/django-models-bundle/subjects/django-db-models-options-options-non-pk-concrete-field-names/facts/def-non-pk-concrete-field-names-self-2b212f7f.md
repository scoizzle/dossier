# Fact 2b212f7f

Store id: 28a88729-6066-4f91-8041-66f753048f3b

## Text

```text
def _non_pk_concrete_field_names(self)
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
- posted_at: `2026-11-09T23:44:55.5994400+00:00`

## Data

```json
{
  "end_line": 1028,
  "entity_kind": "method",
  "parent": "Options",
  "start_line": 1014,
  "symbol": "Options._non_pk_concrete_field_names"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/options.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1014,"selector":"L1014-L1028","symbol":"Options._non_pk_concrete_field_names"}`

## Items

```json
[
  {
    "text": "Return a set of the non-pk concrete field names defined on the model.",
    "locator": {
      "line": 1016
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/options::Options._non_pk_concrete_field_names](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1028,
    "entity_kind": "method",
    "parent": "Options",
    "start_line": 1014,
    "symbol": "Options._non_pk_concrete_field_names"
  },
  "id": "28a88729-6066-4f91-8041-66f753048f3b",
  "items": [
    {
      "locator": {
        "line": 1016
      },
      "text": "Return a set of the non-pk concrete field names defined on the model."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:55.5994400+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1014,
        "selector": "L1014-L1028",
        "symbol": "Options._non_pk_concrete_field_names"
      },
      "rel": "derived_from",
      "target": "django/db/models/options.py"
    }
  ],
  "status": "live",
  "subject_id": "626f4bfa-cade-4770-9a53-52f488e96bcf",
  "subject_name": "django/db/models/options::Options._non_pk_concrete_field_names",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def _non_pk_concrete_field_names(self)"
}
```
