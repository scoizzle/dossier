# Fact af17750b

Store id: fda76032-3af4-46db-9464-1ea0e0335798

## Text

```text
def subclass_exception(name, bases, module, attached_to)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:function`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:48.5169550+00:00`

## Data

```json
{
  "end_line": 87,
  "entity_kind": "function",
  "parent": "base",
  "start_line": 72,
  "symbol": "subclass_exception"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/base.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":72,"selector":"L72-L87","symbol":"subclass_exception"}`

## Items

```json
[
  {
    "text": "Create exception subclass. Used by ModelBase below.",
    "locator": {
      "line": 73
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/base::subclass_exception](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 87,
    "entity_kind": "function",
    "parent": "base",
    "start_line": 72,
    "symbol": "subclass_exception"
  },
  "id": "fda76032-3af4-46db-9464-1ea0e0335798",
  "items": [
    {
      "locator": {
        "line": 73
      },
      "text": "Create exception subclass. Used by ModelBase below."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:48.5169550+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 72,
        "selector": "L72-L87",
        "symbol": "subclass_exception"
      },
      "rel": "derived_from",
      "target": "django/db/models/base.py"
    }
  ],
  "status": "live",
  "subject_id": "9340da12-636e-432e-a41a-f8a7e88df16e",
  "subject_name": "django/db/models/base::subclass_exception",
  "tags": [
    "entity:function"
  ],
  "text": "def subclass_exception(name, bases, module, attached_to)"
}
```
