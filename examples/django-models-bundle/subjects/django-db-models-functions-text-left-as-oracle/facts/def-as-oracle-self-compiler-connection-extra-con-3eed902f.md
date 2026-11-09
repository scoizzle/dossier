# Fact 3eed902f

Store id: eb45a671-1967-488f-b9cf-5c386cbff129

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
- posted_at: `2026-11-09T23:32:02.1934000+00:00`

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
  "id": "eb45a671-1967-488f-b9cf-5c386cbff129",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:02.1934000+00:00"
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
  "subject_id": "cb8396f7-f5da-4b09-aa2a-47ac58ed0f72",
  "subject_name": "django/db/models/functions/text::Left.as_oracle",
  "tags": [
    "entity:method"
  ],
  "text": "def as_oracle(self, compiler, connection, **extra_context)"
}
```
