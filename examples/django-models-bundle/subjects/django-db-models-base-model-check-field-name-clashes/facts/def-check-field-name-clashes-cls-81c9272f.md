# Fact 81c9272f

Store id: 128ca04e-477e-4614-a434-7388e9930bf2

## Text

```text
def _check_field_name_clashes(cls)
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
- posted_at: `2026-11-09T23:44:48.5496700+00:00`

## Data

```json
{
  "end_line": 2078,
  "entity_kind": "class_method",
  "parent": "Model",
  "start_line": 2010,
  "symbol": "Model._check_field_name_clashes"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/base.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2010,"selector":"L2010-L2078","symbol":"Model._check_field_name_clashes"}`

## Items

```json
[
  {
    "text": "Forbid field shadowing in multi-table inheritance.",
    "locator": {
      "line": 2012
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/base::Model._check_field_name_clashes](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2078,
    "entity_kind": "class_method",
    "parent": "Model",
    "start_line": 2010,
    "symbol": "Model._check_field_name_clashes"
  },
  "id": "128ca04e-477e-4614-a434-7388e9930bf2",
  "items": [
    {
      "locator": {
        "line": 2012
      },
      "text": "Forbid field shadowing in multi-table inheritance."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:48.5496700+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2010,
        "selector": "L2010-L2078",
        "symbol": "Model._check_field_name_clashes"
      },
      "rel": "derived_from",
      "target": "django/db/models/base.py"
    }
  ],
  "status": "live",
  "subject_id": "4017c5bd-4a5f-478e-92a2-1c453c332396",
  "subject_name": "django/db/models/base::Model._check_field_name_clashes",
  "tags": [
    "entity:class_method",
    "decorator:classmethod"
  ],
  "text": "def _check_field_name_clashes(cls)"
}
```
