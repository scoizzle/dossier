# Fact 0f8897c6

Store id: f25070d7-3c5c-415c-bf7d-0f2612bcdbfe

## Text

```text
def local_concrete_fields(self)
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
- posted_at: `2026-11-09T23:32:03.9855640+00:00`

## Data

```json
{
  "end_line": 597,
  "entity_kind": "method",
  "parent": "Options",
  "start_line": 586,
  "symbol": "Options.local_concrete_fields"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/options.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":586,"selector":"L586-L597","symbol":"Options.local_concrete_fields"}`

## Items

```json
[
  {
    "text": "Return a list of all concrete fields on the model.",
    "locator": {
      "line": 588
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/options::Options.local_concrete_fields](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 597,
    "entity_kind": "method",
    "parent": "Options",
    "start_line": 586,
    "symbol": "Options.local_concrete_fields"
  },
  "id": "f25070d7-3c5c-415c-bf7d-0f2612bcdbfe",
  "items": [
    {
      "locator": {
        "line": 588
      },
      "text": "Return a list of all concrete fields on the model."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:03.9855640+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 586,
        "selector": "L586-L597",
        "symbol": "Options.local_concrete_fields"
      },
      "rel": "derived_from",
      "target": "django/db/models/options.py"
    }
  ],
  "status": "live",
  "subject_id": "6447dd56-174e-486e-a014-a55a88c4bf36",
  "subject_name": "django/db/models/options::Options.local_concrete_fields",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def local_concrete_fields(self)"
}
```
