# Fact a13ad85b

Store id: 7d6e2d74-3233-49b5-a251-f83c3fab1004

## Text

```text
def default_manager(self)
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
- posted_at: `2026-11-09T22:39:48.8341130+00:00`

## Data

```json
{
  "end_line": 529,
  "entity_kind": "method",
  "parent": "Options",
  "start_line": 506,
  "symbol": "Options.default_manager"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/options.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":506,"selector":"L506-L529","symbol":"Options.default_manager"}`

## Referenced by

None.

## Subject

[django/db/models/options::Options.default_manager](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 529,
    "entity_kind": "method",
    "parent": "Options",
    "start_line": 506,
    "symbol": "Options.default_manager"
  },
  "id": "7d6e2d74-3233-49b5-a251-f83c3fab1004",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:48.8341130+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 506,
        "selector": "L506-L529",
        "symbol": "Options.default_manager"
      },
      "rel": "derived_from",
      "target": "django/db/models/options.py"
    }
  ],
  "status": "live",
  "subject_id": "0463165c-1f8d-476c-8a8f-91ba39c9b9dc",
  "subject_name": "django/db/models/options::Options.default_manager",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def default_manager(self)"
}
```
