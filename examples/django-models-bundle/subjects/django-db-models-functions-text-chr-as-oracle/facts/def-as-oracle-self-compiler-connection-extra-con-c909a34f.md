# Fact c909a34f

Store id: 5692d423-a7dd-42ef-8c83-baa2a9ceae35

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
- posted_at: `2026-11-09T22:39:47.0595410+00:00`

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
  "id": "5692d423-a7dd-42ef-8c83-baa2a9ceae35",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:47.0595410+00:00"
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
  "subject_id": "cc370b8e-bb82-445c-89cd-737035d3ade3",
  "subject_name": "django/db/models/functions/text::Chr.as_oracle",
  "tags": [
    "entity:method"
  ],
  "text": "def as_oracle(self, compiler, connection, **extra_context)"
}
```
