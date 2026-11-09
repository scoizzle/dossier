# Fact bf53ee2e

Store id: 2b4b5e3f-b036-4db5-8104-c366d93d8f49

## Text

```text
def referenced_base_fields(self)
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
- posted_at: `2026-11-09T23:44:56.5989000+00:00`

## Data

```json
{
  "end_line": 247,
  "entity_kind": "method",
  "parent": "Q",
  "start_line": 236,
  "symbol": "Q.referenced_base_fields"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query_utils.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":236,"selector":"L236-L247","symbol":"Q.referenced_base_fields"}`

## Items

```json
[
  {
    "text": "Retrieve all base fields referenced directly or through F expressions excluding any fields referenced through joins.",
    "locator": {
      "line": 238
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/query_utils::Q.referenced_base_fields](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 247,
    "entity_kind": "method",
    "parent": "Q",
    "start_line": 236,
    "symbol": "Q.referenced_base_fields"
  },
  "id": "2b4b5e3f-b036-4db5-8104-c366d93d8f49",
  "items": [
    {
      "locator": {
        "line": 238
      },
      "text": "Retrieve all base fields referenced directly or through F expressions excluding any fields referenced through joins."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:56.5989000+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 236,
        "selector": "L236-L247",
        "symbol": "Q.referenced_base_fields"
      },
      "rel": "derived_from",
      "target": "django/db/models/query_utils.py"
    }
  ],
  "status": "live",
  "subject_id": "2dc735f9-6585-4b9f-a6c9-e87b62430484",
  "subject_name": "django/db/models/query_utils::Q.referenced_base_fields",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def referenced_base_fields(self)"
}
```
