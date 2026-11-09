# Fact e28e84d7

Store id: b7680408-2652-420c-b583-19d66e76fb4b

## Text

```text
def __lt__(self, other)
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
- posted_at: `2026-11-09T22:39:42.3005040+00:00`

## Data

```json
{
  "end_line": 740,
  "entity_kind": "method",
  "parent": "Field",
  "start_line": 722,
  "symbol": "Field.__lt__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":722,"selector":"L722-L740","symbol":"Field.__lt__"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::Field.__lt__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 740,
    "entity_kind": "method",
    "parent": "Field",
    "start_line": 722,
    "symbol": "Field.__lt__"
  },
  "id": "b7680408-2652-420c-b583-19d66e76fb4b",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.3005040+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 722,
        "selector": "L722-L740",
        "symbol": "Field.__lt__"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "68f15e6f-7cb3-42b6-b71b-84e8fc4b3585",
  "subject_name": "django/db/models/fields/__init__::Field.__lt__",
  "tags": [
    "entity:method"
  ],
  "text": "def __lt__(self, other)"
}
```
