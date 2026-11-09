# Fact 58fab214

Store id: 74028ae0-471a-47c2-857d-56f21f97edc4

## Text

```text
def swapped(self)
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
- posted_at: `2026-11-09T23:32:03.9515820+00:00`

## Data

```json
{
  "end_line": 447,
  "entity_kind": "method",
  "parent": "Options",
  "start_line": 421,
  "symbol": "Options.swapped"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/options.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":421,"selector":"L421-L447","symbol":"Options.swapped"}`

## Items

```json
[
  {
    "text": "Has this model been swapped out for another? If so, return the model name of the replacement; otherwise, return None.",
    "locator": {
      "line": 423
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/options::Options.swapped](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 447,
    "entity_kind": "method",
    "parent": "Options",
    "start_line": 421,
    "symbol": "Options.swapped"
  },
  "id": "74028ae0-471a-47c2-857d-56f21f97edc4",
  "items": [
    {
      "locator": {
        "line": 423
      },
      "text": "Has this model been swapped out for another? If so, return the model name of the replacement; otherwise, return None."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:03.9515820+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 421,
        "selector": "L421-L447",
        "symbol": "Options.swapped"
      },
      "rel": "derived_from",
      "target": "django/db/models/options.py"
    }
  ],
  "status": "live",
  "subject_id": "5c26feaa-0bff-40e2-a663-c3b08e898021",
  "subject_name": "django/db/models/options::Options.swapped",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def swapped(self)"
}
```
