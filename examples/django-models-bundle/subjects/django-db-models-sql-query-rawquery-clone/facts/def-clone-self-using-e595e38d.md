# Fact e595e38d

Store id: caf7d39a-59fc-4125-9b1a-1f6a959ae8e2

## Text

```text
def clone(self, using)
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
- posted_at: `2026-11-09T22:39:51.1929000+00:00`

## Data

```json
{
  "end_line": 174,
  "entity_kind": "method",
  "parent": "RawQuery",
  "start_line": 173,
  "symbol": "RawQuery.clone"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":173,"selector":"L173-L174","symbol":"RawQuery.clone"}`

## Referenced by

None.

## Subject

[django/db/models/sql/query::RawQuery.clone](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 174,
    "entity_kind": "method",
    "parent": "RawQuery",
    "start_line": 173,
    "symbol": "RawQuery.clone"
  },
  "id": "caf7d39a-59fc-4125-9b1a-1f6a959ae8e2",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:51.1929000+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 173,
        "selector": "L173-L174",
        "symbol": "RawQuery.clone"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "54b65a0b-be73-41f5-b6ac-3ce4cb2896f8",
  "subject_name": "django/db/models/sql/query::RawQuery.clone",
  "tags": [
    "entity:method"
  ],
  "text": "def clone(self, using)"
}
```
