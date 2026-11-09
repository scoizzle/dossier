# Fact bf53ee2e

Store id: 78c1099e-99eb-49e2-86bd-107e59884f1a

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
- posted_at: `2026-11-09T22:39:50.1066820+00:00`

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
  "id": "78c1099e-99eb-49e2-86bd-107e59884f1a",
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
    "posted_at": "2026-11-09T22:39:50.1066820+00:00"
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
  "subject_id": "3103e8fa-8ab0-4fc2-a2b5-b51d832e8a05",
  "subject_name": "django/db/models/query_utils::Q.referenced_base_fields",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def referenced_base_fields(self)"
}
```
