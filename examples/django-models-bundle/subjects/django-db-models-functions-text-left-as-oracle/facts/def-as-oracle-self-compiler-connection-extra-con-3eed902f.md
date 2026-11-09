# Fact 3eed902f

Store id: f023b9ba-e70a-4c2d-815c-2937bbb23dcf

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
- posted_at: `2026-11-09T22:39:47.1103300+00:00`

## Data

```json
{
  "end_line": 173,
  "entity_kind": "method",
  "parent": "Left",
  "start_line": 172,
  "symbol": "Left.as_oracle"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/text.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":172,"selector":"L172-L173","symbol":"Left.as_oracle"}`

## Referenced by

None.

## Subject

[django/db/models/functions/text::Left.as_oracle](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 173,
    "entity_kind": "method",
    "parent": "Left",
    "start_line": 172,
    "symbol": "Left.as_oracle"
  },
  "id": "f023b9ba-e70a-4c2d-815c-2937bbb23dcf",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:47.1103300+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 172,
        "selector": "L172-L173",
        "symbol": "Left.as_oracle"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/text.py"
    }
  ],
  "status": "live",
  "subject_id": "531b1098-6593-435d-9479-bffc3a36e96f",
  "subject_name": "django/db/models/functions/text::Left.as_oracle",
  "tags": [
    "entity:method"
  ],
  "text": "def as_oracle(self, compiler, connection, **extra_context)"
}
```
