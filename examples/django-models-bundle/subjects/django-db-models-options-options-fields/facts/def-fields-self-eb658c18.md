# Fact eb658c18

Store id: 62b1692b-348a-40d1-9347-f2cf78ee185e

## Text

```text
def fields(self)
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
- posted_at: `2026-11-09T23:44:55.5244480+00:00`

## Data

```json
{
  "end_line": 571,
  "entity_kind": "method",
  "parent": "Options",
  "start_line": 531,
  "symbol": "Options.fields"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/options.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":531,"selector":"L531-L571","symbol":"Options.fields"}`

## Items

```json
[
  {
    "text": "Return a list of all forward fields on the model and its parents, excluding ManyToManyFields.",
    "locator": {
      "line": 533
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/options::Options.fields](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 571,
    "entity_kind": "method",
    "parent": "Options",
    "start_line": 531,
    "symbol": "Options.fields"
  },
  "id": "62b1692b-348a-40d1-9347-f2cf78ee185e",
  "items": [
    {
      "locator": {
        "line": 533
      },
      "text": "Return a list of all forward fields on the model and its parents, excluding ManyToManyFields."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:55.5244480+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 531,
        "selector": "L531-L571",
        "symbol": "Options.fields"
      },
      "rel": "derived_from",
      "target": "django/db/models/options.py"
    }
  ],
  "status": "live",
  "subject_id": "3513138b-c8fe-4d4c-8b66-c2f420b87746",
  "subject_name": "django/db/models/options::Options.fields",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def fields(self)"
}
```
