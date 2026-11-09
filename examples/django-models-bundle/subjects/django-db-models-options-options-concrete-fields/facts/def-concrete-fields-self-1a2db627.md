# Fact 1a2db627

Store id: a62b1958-1bf0-48f4-aad2-71fef4985eef

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
- posted_at: `2026-11-09T22:39:48.8492760+00:00`

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
  "id": "a62b1958-1bf0-48f4-aad2-71fef4985eef",
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
    "posted_at": "2026-11-09T22:39:48.8492760+00:00"
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
  "subject_id": "7625c6c0-8bcd-4246-851b-f6acc27f104a",
  "subject_name": "django/db/models/options::Options.concrete_fields",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def concrete_fields(self)"
}
```
