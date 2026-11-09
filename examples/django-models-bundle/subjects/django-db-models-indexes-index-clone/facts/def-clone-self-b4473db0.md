# Fact b4473db0

Store id: 0d1bf639-c84f-40bd-88f1-3f08cd43d4ef

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
- posted_at: `2026-11-09T23:32:02.9264120+00:00`

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
  "id": "0d1bf639-c84f-40bd-88f1-3f08cd43d4ef",
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
    "posted_at": "2026-11-09T23:32:02.9264120+00:00"
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
  "subject_id": "2d496ac2-189b-4594-941a-5c140df155e1",
  "subject_name": "django/db/models/indexes::Index.clone",
  "tags": [
    "entity:method"
  ],
  "text": "def clone(self)"
}
```
