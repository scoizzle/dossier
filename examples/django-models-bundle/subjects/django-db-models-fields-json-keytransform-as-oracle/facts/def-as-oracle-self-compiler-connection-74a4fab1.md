# Fact 74a4fab1

Store id: 73a0bc22-b416-4fa8-80ad-85b0642318d3

## Text

```text
def as_oracle(self, compiler, connection)
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
- posted_at: `2026-11-09T23:44:51.0236240+00:00`

## Data

```json
{
  "end_line": 522,
  "entity_kind": "method",
  "parent": "KeyTransform",
  "start_line": 520,
  "symbol": "KeyTransform.as_oracle"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/json.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":520,"selector":"L520-L522","symbol":"KeyTransform.as_oracle"}`

## Referenced by

None.

## Subject

[django/db/models/fields/json::KeyTransform.as_oracle](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 522,
    "entity_kind": "method",
    "parent": "KeyTransform",
    "start_line": 520,
    "symbol": "KeyTransform.as_oracle"
  },
  "id": "73a0bc22-b416-4fa8-80ad-85b0642318d3",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.0236240+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 520,
        "selector": "L520-L522",
        "symbol": "KeyTransform.as_oracle"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/json.py"
    }
  ],
  "status": "live",
  "subject_id": "8c0dd969-2160-4c5e-846f-467de443f144",
  "subject_name": "django/db/models/fields/json::KeyTransform.as_oracle",
  "tags": [
    "entity:method"
  ],
  "text": "def as_oracle(self, compiler, connection)"
}
```
