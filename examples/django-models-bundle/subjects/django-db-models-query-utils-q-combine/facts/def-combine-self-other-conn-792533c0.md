# Fact 792533c0

Store id: 2b6b5fb7-7044-4781-82e8-a91415d61595

## Text

```text
def _combine(self, other, conn)
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
- posted_at: `2026-11-09T22:39:50.0589580+00:00`

## Data

```json
{
  "end_line": 85,
  "entity_kind": "method",
  "parent": "Q",
  "start_line": 74,
  "symbol": "Q._combine"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query_utils.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":74,"selector":"L74-L85","symbol":"Q._combine"}`

## Referenced by

None.

## Subject

[django/db/models/query_utils::Q._combine](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 85,
    "entity_kind": "method",
    "parent": "Q",
    "start_line": 74,
    "symbol": "Q._combine"
  },
  "id": "2b6b5fb7-7044-4781-82e8-a91415d61595",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:50.0589580+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 74,
        "selector": "L74-L85",
        "symbol": "Q._combine"
      },
      "rel": "derived_from",
      "target": "django/db/models/query_utils.py"
    }
  ],
  "status": "live",
  "subject_id": "14936c37-35d6-4961-8281-b6b7dde174e9",
  "subject_name": "django/db/models/query_utils::Q._combine",
  "tags": [
    "entity:method"
  ],
  "text": "def _combine(self, other, conn)"
}
```
