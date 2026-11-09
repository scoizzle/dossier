# Fact c909a34f

Store id: 3b50e652-e31a-468f-992d-f6aaff1981b7

## Text

```text
def as_oracle(self, compiler, connection, **extra_context)
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
- posted_at: `2026-11-09T23:44:54.0488820+00:00`

## Data

```json
{
  "end_line": 62,
  "entity_kind": "method",
  "parent": "Chr",
  "start_line": 56,
  "symbol": "Chr.as_oracle"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/text.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":56,"selector":"L56-L62","symbol":"Chr.as_oracle"}`

## Referenced by

None.

## Subject

[django/db/models/functions/text::Chr.as_oracle](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 62,
    "entity_kind": "method",
    "parent": "Chr",
    "start_line": 56,
    "symbol": "Chr.as_oracle"
  },
  "id": "3b50e652-e31a-468f-992d-f6aaff1981b7",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:54.0488820+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 56,
        "selector": "L56-L62",
        "symbol": "Chr.as_oracle"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/text.py"
    }
  ],
  "status": "live",
  "subject_id": "405c0625-8f2d-4fd3-a3ea-f95526734e62",
  "subject_name": "django/db/models/functions/text::Chr.as_oracle",
  "tags": [
    "entity:method"
  ],
  "text": "def as_oracle(self, compiler, connection, **extra_context)"
}
```
