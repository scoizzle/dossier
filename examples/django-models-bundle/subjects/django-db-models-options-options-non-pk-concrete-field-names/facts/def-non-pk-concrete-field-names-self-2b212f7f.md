# Fact 2b212f7f

Store id: 6eaa61a0-5895-458d-8cab-29b5e0a325ac

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
- posted_at: `2026-11-09T22:39:48.9774240+00:00`

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
  "id": "6eaa61a0-5895-458d-8cab-29b5e0a325ac",
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
    "posted_at": "2026-11-09T22:39:48.9774240+00:00"
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
  "subject_id": "f26ff6f9-4c34-482a-9b14-b3b0293919bc",
  "subject_name": "django/db/models/options::Options._non_pk_concrete_field_names",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def _non_pk_concrete_field_names(self)"
}
```
