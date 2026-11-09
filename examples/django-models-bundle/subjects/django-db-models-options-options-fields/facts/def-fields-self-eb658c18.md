# Fact eb658c18

Store id: 33b41272-aacf-4df7-899d-68580903686d

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
- posted_at: `2026-11-09T22:39:48.8371380+00:00`

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
  "id": "33b41272-aacf-4df7-899d-68580903686d",
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
    "posted_at": "2026-11-09T22:39:48.8371380+00:00"
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
  "subject_id": "e1bb0b4c-f7cb-401a-9b9d-57a6f5c431d2",
  "subject_name": "django/db/models/options::Options.fields",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def fields(self)"
}
```
