# Fact 58fab214

Store id: 0c36eab6-ee73-4113-8590-2cb0e565c55d

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
- posted_at: `2026-11-09T22:39:48.8165030+00:00`

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
  "id": "0c36eab6-ee73-4113-8590-2cb0e565c55d",
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
    "posted_at": "2026-11-09T22:39:48.8165030+00:00"
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
  "subject_id": "6928ecbe-bf93-4504-b92b-61a70cef1422",
  "subject_name": "django/db/models/options::Options.swapped",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def swapped(self)"
}
```
