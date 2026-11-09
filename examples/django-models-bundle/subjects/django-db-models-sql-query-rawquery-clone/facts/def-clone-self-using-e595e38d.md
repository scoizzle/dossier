# Fact e595e38d

Store id: fc7a9c68-a958-4b26-a2f9-67f5d4e3c203

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
- posted_at: `2026-11-09T23:32:06.7099110+00:00`

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
  "id": "fc7a9c68-a958-4b26-a2f9-67f5d4e3c203",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:06.7099110+00:00"
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
  "subject_id": "68be750d-74aa-4577-b174-fd2a3ab908f0",
  "subject_name": "django/db/models/sql/query::RawQuery.clone",
  "tags": [
    "entity:method"
  ],
  "text": "def clone(self, using)"
}
```
