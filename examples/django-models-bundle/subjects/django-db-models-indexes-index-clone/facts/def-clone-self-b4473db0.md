# Fact b4473db0

Store id: a82af15c-7daf-45a5-8b70-afd7f8b2f2d6

## Text

```text
def clone(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:54.6892230+00:00`

## Data

```json
{
  "end_line": 248,
  "entity_kind": "method",
  "parent": "Index",
  "start_line": 245,
  "symbol": "Index.clone"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/indexes.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":245,"selector":"L245-L248","symbol":"Index.clone"}`

## Items

```json
[
  {
    "text": "Create a copy of this Index.",
    "locator": {
      "line": 246
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/indexes::Index.clone](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 248,
    "entity_kind": "method",
    "parent": "Index",
    "start_line": 245,
    "symbol": "Index.clone"
  },
  "id": "a82af15c-7daf-45a5-8b70-afd7f8b2f2d6",
  "items": [
    {
      "locator": {
        "line": 246
      },
      "text": "Create a copy of this Index."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:54.6892230+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 245,
        "selector": "L245-L248",
        "symbol": "Index.clone"
      },
      "rel": "derived_from",
      "target": "django/db/models/indexes.py"
    }
  ],
  "status": "live",
  "subject_id": "9019bdc7-bcc6-48ba-8e6c-5224be5c38aa",
  "subject_name": "django/db/models/indexes::Index.clone",
  "tags": [
    "entity:method"
  ],
  "text": "def clone(self)"
}
```
