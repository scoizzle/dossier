# Fact 1a2db627

Store id: ec78e27e-fbfa-486f-a04e-0ca2776f6553

## Text

```text
def concrete_fields(self)
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
- posted_at: `2026-11-09T23:32:03.9816520+00:00`

## Data

```json
{
  "end_line": 584,
  "entity_kind": "method",
  "parent": "Options",
  "start_line": 573,
  "symbol": "Options.concrete_fields"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/options.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":573,"selector":"L573-L584","symbol":"Options.concrete_fields"}`

## Items

```json
[
  {
    "text": "Return a list of all concrete fields on the model and its parents.",
    "locator": {
      "line": 575
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/options::Options.concrete_fields](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 584,
    "entity_kind": "method",
    "parent": "Options",
    "start_line": 573,
    "symbol": "Options.concrete_fields"
  },
  "id": "ec78e27e-fbfa-486f-a04e-0ca2776f6553",
  "items": [
    {
      "locator": {
        "line": 575
      },
      "text": "Return a list of all concrete fields on the model and its parents."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:03.9816520+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 573,
        "selector": "L573-L584",
        "symbol": "Options.concrete_fields"
      },
      "rel": "derived_from",
      "target": "django/db/models/options.py"
    }
  ],
  "status": "live",
  "subject_id": "878a942b-4306-428a-95ec-6d42b018e5b8",
  "subject_name": "django/db/models/options::Options.concrete_fields",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def concrete_fields(self)"
}
```
