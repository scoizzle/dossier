# Fact b5838476

Store id: d632ccee-d099-4f86-b510-d428c1aaa9c7

## Text

```text
class FloatField(Field)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:31:56.6845050+00:00`

## Data

```json
{
  "end_line": 2138,
  "entity_kind": "class",
  "parent": "__init__",
  "start_line": 2099,
  "symbol": "FloatField"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2099,"selector":"L2099-L2138","symbol":"FloatField"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::FloatField](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2138,
    "entity_kind": "class",
    "parent": "__init__",
    "start_line": 2099,
    "symbol": "FloatField"
  },
  "id": "d632ccee-d099-4f86-b510-d428c1aaa9c7",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.6845050+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2099,
        "selector": "L2099-L2138",
        "symbol": "FloatField"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "1252b3f3-c52d-46c0-acad-69041080cd6f",
  "subject_name": "django/db/models/fields/__init__::FloatField",
  "tags": [
    "entity:class"
  ],
  "text": "class FloatField(Field)"
}
```
