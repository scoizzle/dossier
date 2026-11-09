# Fact a13ad85b

Store id: aa98aed4-664d-4cf4-92c6-a3b6586af659

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
- posted_at: `2026-11-09T23:32:03.9666340+00:00`

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
  "id": "aa98aed4-664d-4cf4-92c6-a3b6586af659",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:03.9666340+00:00"
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
  "subject_id": "5a8c640a-2f39-4c63-b8d4-ac2b53c471df",
  "subject_name": "django/db/models/options::Options.default_manager",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def default_manager(self)"
}
```
