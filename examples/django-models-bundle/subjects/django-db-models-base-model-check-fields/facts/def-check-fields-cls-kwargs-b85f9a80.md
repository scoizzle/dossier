# Fact b85f9a80

Store id: 36828afa-a509-4386-812e-ff3af8e2bfd1

## Text

```text
def _check_fields(cls, **kwargs)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class_method`, `decorator:classmethod`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:31:53.7633360+00:00`

## Data

```json
{
  "end_line": 1951,
  "entity_kind": "class_method",
  "parent": "Model",
  "start_line": 1943,
  "symbol": "Model._check_fields"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/base.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1943,"selector":"L1943-L1951","symbol":"Model._check_fields"}`

## Items

```json
[
  {
    "text": "Perform all field checks.",
    "locator": {
      "line": 1945
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/base::Model._check_fields](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1951,
    "entity_kind": "class_method",
    "parent": "Model",
    "start_line": 1943,
    "symbol": "Model._check_fields"
  },
  "id": "36828afa-a509-4386-812e-ff3af8e2bfd1",
  "items": [
    {
      "locator": {
        "line": 1945
      },
      "text": "Perform all field checks."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:53.7633360+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1943,
        "selector": "L1943-L1951",
        "symbol": "Model._check_fields"
      },
      "rel": "derived_from",
      "target": "django/db/models/base.py"
    }
  ],
  "status": "live",
  "subject_id": "8f654f89-c8b2-4c35-8a71-2a0d43bb7879",
  "subject_name": "django/db/models/base::Model._check_fields",
  "tags": [
    "entity:class_method",
    "decorator:classmethod"
  ],
  "text": "def _check_fields(cls, **kwargs)"
}
```
